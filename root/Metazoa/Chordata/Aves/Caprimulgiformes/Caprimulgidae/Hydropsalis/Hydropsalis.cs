using AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae.Hydropsalis;

/// <summary>
/// Abstract class for Hydropsalis (genus).
/// NCBI TaxId: 335116
/// </summary>
public abstract class Hydropsalis : Caprimulgidae, IHydropsalis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hydropsalis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 335116;

    /// <inheritdoc />
    public virtual string GenusName => "Hydropsalis";

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
