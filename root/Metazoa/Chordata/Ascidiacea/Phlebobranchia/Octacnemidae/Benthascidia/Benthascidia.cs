using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Octacnemidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Octacnemidae.Benthascidia;

/// <summary>
/// Abstract class for Benthascidia (genus).
/// NCBI TaxId: 3680860
/// </summary>
public abstract class Benthascidia : Octacnemidae, IBenthascidia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Benthascidia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3680860;

    /// <inheritdoc />
    public virtual string GenusName => "Benthascidia";

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
