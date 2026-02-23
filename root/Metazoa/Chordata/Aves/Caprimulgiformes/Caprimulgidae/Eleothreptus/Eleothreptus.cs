using AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae.Eleothreptus;

/// <summary>
/// Abstract class for Eleothreptus (genus).
/// NCBI TaxId: 335114
/// </summary>
public abstract class Eleothreptus : Caprimulgidae, IEleothreptus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eleothreptus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 335114;

    /// <inheritdoc />
    public virtual string GenusName => "Eleothreptus";

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
