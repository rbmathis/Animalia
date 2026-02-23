using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Schismorhynchus;

/// <summary>
/// Abstract class for Schismorhynchus (genus).
/// NCBI TaxId: 2589339
/// </summary>
public abstract class Schismorhynchus : Ophichthidae, ISchismorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Schismorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2589339;

    /// <inheritdoc />
    public virtual string GenusName => "Schismorhynchus";

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
