using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Cottidae.Taurocottus;

/// <summary>
/// Abstract class for Taurocottus (genus).
/// NCBI TaxId: 1849265
/// </summary>
public abstract class Taurocottus : Cottidae, ITaurocottus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Taurocottus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1849265;

    /// <inheritdoc />
    public virtual string GenusName => "Taurocottus";

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
