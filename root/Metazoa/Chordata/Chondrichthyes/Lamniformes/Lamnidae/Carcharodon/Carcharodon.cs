using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Lamnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Lamniformes.Lamnidae.Carcharodon;

/// <summary>
/// Abstract class for Carcharodon (genus).
/// NCBI TaxId: 13396
/// </summary>
public abstract class Carcharodon : Lamnidae, ICarcharodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carcharodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13396;

    /// <inheritdoc />
    public virtual string GenusName => "Carcharodon";

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
