using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Trachinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Trachinidae.Echiichthys;

/// <summary>
/// Abstract class for Echiichthys (genus).
/// NCBI TaxId: 94983
/// </summary>
public abstract class Echiichthys : Trachinidae, IEchiichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Echiichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94983;

    /// <inheritdoc />
    public virtual string GenusName => "Echiichthys";

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
