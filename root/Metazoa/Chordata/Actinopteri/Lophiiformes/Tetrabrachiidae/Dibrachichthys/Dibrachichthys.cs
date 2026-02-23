using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Tetrabrachiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Tetrabrachiidae.Dibrachichthys;

/// <summary>
/// Abstract class for Dibrachichthys (genus).
/// NCBI TaxId: 683830
/// </summary>
public abstract class Dibrachichthys : Tetrabrachiidae, IDibrachichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dibrachichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 683830;

    /// <inheritdoc />
    public virtual string GenusName => "Dibrachichthys";

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
