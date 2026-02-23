using AnimalKingdom.root.Metazoa.Chordata.Leptocardii.Amphioxiformes.Branchiostomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Leptocardii.Amphioxiformes.Branchiostomatidae.Asymmetron;

/// <summary>
/// Abstract class for Asymmetron (genus).
/// NCBI TaxId: 355595
/// </summary>
public abstract class Asymmetron : Branchiostomatidae, IAsymmetron
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Asymmetron";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 355595;

    /// <inheritdoc />
    public virtual string GenusName => "Asymmetron";

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
