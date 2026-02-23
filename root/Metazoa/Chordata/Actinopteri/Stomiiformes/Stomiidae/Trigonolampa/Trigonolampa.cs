using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Trigonolampa;

/// <summary>
/// Abstract class for Trigonolampa (genus).
/// NCBI TaxId: 882888
/// </summary>
public abstract class Trigonolampa : Stomiidae, ITrigonolampa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trigonolampa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 882888;

    /// <inheritdoc />
    public virtual string GenusName => "Trigonolampa";

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
