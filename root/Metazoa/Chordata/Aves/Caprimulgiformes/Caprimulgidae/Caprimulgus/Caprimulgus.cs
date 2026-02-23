using AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae.Caprimulgus;

/// <summary>
/// Abstract class for Caprimulgus (genus).
/// NCBI TaxId: 48284
/// </summary>
public abstract class Caprimulgus : Caprimulgidae, ICaprimulgus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caprimulgus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48284;

    /// <inheritdoc />
    public virtual string GenusName => "Caprimulgus";

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
