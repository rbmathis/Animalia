using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Nemacheilidae.Traccatichthys;

/// <summary>
/// Abstract class for Traccatichthys (genus).
/// NCBI TaxId: 2162843
/// </summary>
public abstract class Traccatichthys : Nemacheilidae, ITraccatichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Traccatichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2162843;

    /// <inheritdoc />
    public virtual string GenusName => "Traccatichthys";

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
