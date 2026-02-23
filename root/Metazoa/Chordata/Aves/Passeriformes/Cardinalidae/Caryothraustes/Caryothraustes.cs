using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cardinalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cardinalidae.Caryothraustes;

/// <summary>
/// Abstract class for Caryothraustes (genus).
/// NCBI TaxId: 460167
/// </summary>
public abstract class Caryothraustes : Cardinalidae, ICaryothraustes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caryothraustes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 460167;

    /// <inheritdoc />
    public virtual string GenusName => "Caryothraustes";

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
