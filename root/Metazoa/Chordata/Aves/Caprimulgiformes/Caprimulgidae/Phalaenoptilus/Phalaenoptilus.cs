using AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae.Phalaenoptilus;

/// <summary>
/// Abstract class for Phalaenoptilus (genus).
/// NCBI TaxId: 48436
/// </summary>
public abstract class Phalaenoptilus : Caprimulgidae, IPhalaenoptilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phalaenoptilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48436;

    /// <inheritdoc />
    public virtual string GenusName => "Phalaenoptilus";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
