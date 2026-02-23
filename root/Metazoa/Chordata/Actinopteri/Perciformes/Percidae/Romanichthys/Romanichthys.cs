using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Romanichthys;

/// <summary>
/// Abstract class for Romanichthys (genus).
/// NCBI TaxId: 77143
/// </summary>
public abstract class Romanichthys : Percidae, IRomanichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Romanichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 77143;

    /// <inheritdoc />
    public virtual string GenusName => "Romanichthys";

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
