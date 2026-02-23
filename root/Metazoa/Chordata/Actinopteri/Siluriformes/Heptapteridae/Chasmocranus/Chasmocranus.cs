using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Chasmocranus;

/// <summary>
/// Abstract class for Chasmocranus (genus).
/// NCBI TaxId: 1123909
/// </summary>
public abstract class Chasmocranus : Heptapteridae, IChasmocranus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chasmocranus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1123909;

    /// <inheritdoc />
    public virtual string GenusName => "Chasmocranus";

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
