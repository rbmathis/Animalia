using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Congiopodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Perciformes_incertae_sedis.Congiopodidae.Alertichthys;

/// <summary>
/// Abstract class for Alertichthys (genus).
/// NCBI TaxId: 2696641
/// </summary>
public abstract class Alertichthys : Congiopodidae, IAlertichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alertichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2696641;

    /// <inheritdoc />
    public virtual string GenusName => "Alertichthys";

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
