using AnimalKingdom.root.Metazoa.Chordata.Aves.Struthioniformes.Aepyornithidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Struthioniformes.Aepyornithidae.Aepyornis;

/// <summary>
/// Abstract class for Aepyornis (genus).
/// NCBI TaxId: 748141
/// </summary>
public abstract class Aepyornis : Aepyornithidae, IAepyornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aepyornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 748141;

    /// <inheritdoc />
    public virtual string GenusName => "Aepyornis";

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
