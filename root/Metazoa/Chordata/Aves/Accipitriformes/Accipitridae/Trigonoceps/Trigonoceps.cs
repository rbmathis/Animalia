using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Trigonoceps;

/// <summary>
/// Abstract class for Trigonoceps (genus).
/// NCBI TaxId: 8974
/// </summary>
public abstract class Trigonoceps : Accipitridae, ITrigonoceps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trigonoceps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8974;

    /// <inheritdoc />
    public virtual string GenusName => "Trigonoceps";

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
