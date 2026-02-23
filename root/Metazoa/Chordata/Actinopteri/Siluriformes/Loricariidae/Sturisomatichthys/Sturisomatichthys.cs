using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Sturisomatichthys;

/// <summary>
/// Abstract class for Sturisomatichthys (genus).
/// NCBI TaxId: 503162
/// </summary>
public abstract class Sturisomatichthys : Loricariidae, ISturisomatichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sturisomatichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 503162;

    /// <inheritdoc />
    public virtual string GenusName => "Sturisomatichthys";

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
