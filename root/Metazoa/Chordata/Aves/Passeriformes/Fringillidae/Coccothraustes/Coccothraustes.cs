using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Coccothraustes;

/// <summary>
/// Abstract class for Coccothraustes (genus).
/// NCBI TaxId: 37608
/// </summary>
public abstract class Coccothraustes : Fringillidae, ICoccothraustes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coccothraustes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 37608;

    /// <inheritdoc />
    public virtual string GenusName => "Coccothraustes";

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
