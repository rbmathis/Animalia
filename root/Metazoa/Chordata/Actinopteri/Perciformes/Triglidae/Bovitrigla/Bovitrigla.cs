using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Triglidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Triglidae.Bovitrigla;

/// <summary>
/// Abstract class for Bovitrigla (genus).
/// NCBI TaxId: 2608472
/// </summary>
public abstract class Bovitrigla : Triglidae, IBovitrigla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bovitrigla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2608472;

    /// <inheritdoc />
    public virtual string GenusName => "Bovitrigla";

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
