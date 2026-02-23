using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Elachocharax;

/// <summary>
/// Abstract class for Elachocharax (genus).
/// NCBI TaxId: 304030
/// </summary>
public abstract class Elachocharax : Characidae, IElachocharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Elachocharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304030;

    /// <inheritdoc />
    public virtual string GenusName => "Elachocharax";

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
