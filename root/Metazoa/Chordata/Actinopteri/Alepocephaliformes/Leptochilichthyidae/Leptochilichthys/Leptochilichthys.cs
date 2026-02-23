using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Leptochilichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Leptochilichthyidae.Leptochilichthys;

/// <summary>
/// Abstract class for Leptochilichthys (genus).
/// NCBI TaxId: 443635
/// </summary>
public abstract class Leptochilichthys : Leptochilichthyidae, ILeptochilichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptochilichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 443635;

    /// <inheritdoc />
    public virtual string GenusName => "Leptochilichthys";

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
