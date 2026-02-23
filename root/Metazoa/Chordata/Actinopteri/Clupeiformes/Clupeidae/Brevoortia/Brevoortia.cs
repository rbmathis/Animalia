using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Brevoortia;

/// <summary>
/// Abstract class for Brevoortia (genus).
/// NCBI TaxId: 224706
/// </summary>
public abstract class Brevoortia : Clupeidae, IBrevoortia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brevoortia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 224706;

    /// <inheritdoc />
    public virtual string GenusName => "Brevoortia";

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
