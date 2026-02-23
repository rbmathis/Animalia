using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae.Ophiclinops;

/// <summary>
/// Abstract class for Ophiclinops (genus).
/// NCBI TaxId: 1385884
/// </summary>
public abstract class Ophiclinops : Clinidae, IOphiclinops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ophiclinops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1385884;

    /// <inheritdoc />
    public virtual string GenusName => "Ophiclinops";

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
