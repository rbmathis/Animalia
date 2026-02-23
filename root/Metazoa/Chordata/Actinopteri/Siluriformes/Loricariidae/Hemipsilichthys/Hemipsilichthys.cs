using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Hemipsilichthys;

/// <summary>
/// Abstract class for Hemipsilichthys (genus).
/// NCBI TaxId: 245753
/// </summary>
public abstract class Hemipsilichthys : Loricariidae, IHemipsilichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemipsilichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 245753;

    /// <inheritdoc />
    public virtual string GenusName => "Hemipsilichthys";

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
