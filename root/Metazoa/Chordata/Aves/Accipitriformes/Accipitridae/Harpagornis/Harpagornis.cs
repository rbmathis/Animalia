using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Harpagornis;

/// <summary>
/// Abstract class for Harpagornis (genus).
/// NCBI TaxId: 307642
/// </summary>
public abstract class Harpagornis : Accipitridae, IHarpagornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Harpagornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 307642;

    /// <inheritdoc />
    public virtual string GenusName => "Harpagornis";

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
