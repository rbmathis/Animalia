using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Centrophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Centrophoridae.Deania;

/// <summary>
/// Abstract class for Deania (genus).
/// NCBI TaxId: 170818
/// </summary>
public abstract class Deania : Centrophoridae, IDeania
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Deania";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 170818;

    /// <inheritdoc />
    public virtual string GenusName => "Deania";

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
