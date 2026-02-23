using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Utiaritichthys;

/// <summary>
/// Abstract class for Utiaritichthys (genus).
/// NCBI TaxId: 2218684
/// </summary>
public abstract class Utiaritichthys : Serrasalmidae, IUtiaritichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Utiaritichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2218684;

    /// <inheritdoc />
    public virtual string GenusName => "Utiaritichthys";

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
