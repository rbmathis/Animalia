using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Sarpa;

/// <summary>
/// Abstract class for Sarpa (genus).
/// NCBI TaxId: 87758
/// </summary>
public abstract class Sarpa : Sparidae, ISarpa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sarpa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 87758;

    /// <inheritdoc />
    public virtual string GenusName => "Sarpa";

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
