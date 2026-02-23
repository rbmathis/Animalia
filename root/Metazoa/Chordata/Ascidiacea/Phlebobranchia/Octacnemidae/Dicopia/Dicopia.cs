using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Octacnemidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Octacnemidae.Dicopia;

/// <summary>
/// Abstract class for Dicopia (genus).
/// NCBI TaxId: 2060131
/// </summary>
public abstract class Dicopia : Octacnemidae, IDicopia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dicopia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2060131;

    /// <inheritdoc />
    public virtual string GenusName => "Dicopia";

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
