using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Chelaethiops;

/// <summary>
/// Abstract class for Chelaethiops (genus).
/// NCBI TaxId: 857688
/// </summary>
public abstract class Chelaethiops : Danionidae, IChelaethiops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chelaethiops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 857688;

    /// <inheritdoc />
    public virtual string GenusName => "Chelaethiops";

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
