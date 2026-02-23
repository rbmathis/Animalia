using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Zanclorhynchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Zanclorhynchidae.Zanclorhynchus;

/// <summary>
/// Abstract class for Zanclorhynchus (genus).
/// NCBI TaxId: 274725
/// </summary>
public abstract class Zanclorhynchus : Zanclorhynchidae, IZanclorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zanclorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274725;

    /// <inheritdoc />
    public virtual string GenusName => "Zanclorhynchus";

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
