using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae.Diplogrammus;

/// <summary>
/// Abstract class for Diplogrammus (genus).
/// NCBI TaxId: 1003947
/// </summary>
public abstract class Diplogrammus : Callionymidae, IDiplogrammus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diplogrammus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1003947;

    /// <inheritdoc />
    public virtual string GenusName => "Diplogrammus";

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
