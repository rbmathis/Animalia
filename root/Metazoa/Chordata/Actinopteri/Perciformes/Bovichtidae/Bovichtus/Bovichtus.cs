using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bovichtidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Bovichtidae.Bovichtus;

/// <summary>
/// Abstract class for Bovichtus (genus).
/// NCBI TaxId: 36204
/// </summary>
public abstract class Bovichtus : Bovichtidae, IBovichtus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bovichtus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36204;

    /// <inheritdoc />
    public virtual string GenusName => "Bovichtus";

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
