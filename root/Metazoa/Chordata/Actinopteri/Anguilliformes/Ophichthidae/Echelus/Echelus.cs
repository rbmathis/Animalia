using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Echelus;

/// <summary>
/// Abstract class for Echelus (genus).
/// NCBI TaxId: 391185
/// </summary>
public abstract class Echelus : Ophichthidae, IEchelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Echelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 391185;

    /// <inheritdoc />
    public virtual string GenusName => "Echelus";

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
