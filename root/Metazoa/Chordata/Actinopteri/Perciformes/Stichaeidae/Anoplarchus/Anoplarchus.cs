using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Stichaeidae.Anoplarchus;

/// <summary>
/// Abstract class for Anoplarchus (genus).
/// NCBI TaxId: 320622
/// </summary>
public abstract class Anoplarchus : Stichaeidae, IAnoplarchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anoplarchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 320622;

    /// <inheritdoc />
    public virtual string GenusName => "Anoplarchus";

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
