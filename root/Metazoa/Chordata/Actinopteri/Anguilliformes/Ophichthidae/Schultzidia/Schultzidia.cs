using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Schultzidia;

/// <summary>
/// Abstract class for Schultzidia (genus).
/// NCBI TaxId: 2488697
/// </summary>
public abstract class Schultzidia : Ophichthidae, ISchultzidia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Schultzidia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2488697;

    /// <inheritdoc />
    public virtual string GenusName => "Schultzidia";

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
