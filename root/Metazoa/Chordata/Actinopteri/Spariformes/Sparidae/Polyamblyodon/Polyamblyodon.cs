using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Polyamblyodon;

/// <summary>
/// Abstract class for Polyamblyodon (genus).
/// NCBI TaxId: 119733
/// </summary>
public abstract class Polyamblyodon : Sparidae, IPolyamblyodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polyamblyodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 119733;

    /// <inheritdoc />
    public virtual string GenusName => "Polyamblyodon";

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
