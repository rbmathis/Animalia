using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Nothonotus;

/// <summary>
/// Abstract class for Nothonotus (genus).
/// NCBI TaxId: 3382257
/// </summary>
public abstract class Nothonotus : Percidae, INothonotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nothonotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3382257;

    /// <inheritdoc />
    public virtual string GenusName => "Nothonotus";

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
