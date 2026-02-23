using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Triglidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Triglidae.Chelidonichthys;

/// <summary>
/// Abstract class for Chelidonichthys (genus).
/// NCBI TaxId: 33533
/// </summary>
public abstract class Chelidonichthys : Triglidae, IChelidonichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chelidonichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 33533;

    /// <inheritdoc />
    public virtual string GenusName => "Chelidonichthys";

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
