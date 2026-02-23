using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Sturisoma;

/// <summary>
/// Abstract class for Sturisoma (genus).
/// NCBI TaxId: 337758
/// </summary>
public abstract class Sturisoma : Loricariidae, ISturisoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sturisoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337758;

    /// <inheritdoc />
    public virtual string GenusName => "Sturisoma";

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
