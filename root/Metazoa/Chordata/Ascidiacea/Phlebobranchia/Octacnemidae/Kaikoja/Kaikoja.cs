using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Octacnemidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Octacnemidae.Kaikoja;

/// <summary>
/// Abstract class for Kaikoja (genus).
/// NCBI TaxId: 3475075
/// </summary>
public abstract class Kaikoja : Octacnemidae, IKaikoja
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kaikoja";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3475075;

    /// <inheritdoc />
    public virtual string GenusName => "Kaikoja";

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
