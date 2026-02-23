using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Channichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Channichthyidae.Dacodraco;

/// <summary>
/// Abstract class for Dacodraco (genus).
/// NCBI TaxId: 70443
/// </summary>
public abstract class Dacodraco : Channichthyidae, IDacodraco
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dacodraco";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 70443;

    /// <inheritdoc />
    public virtual string GenusName => "Dacodraco";

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
