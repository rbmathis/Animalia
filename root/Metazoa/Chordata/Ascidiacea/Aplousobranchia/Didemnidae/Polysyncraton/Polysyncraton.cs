using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Didemnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Aplousobranchia.Didemnidae.Polysyncraton;

/// <summary>
/// Abstract class for Polysyncraton (genus).
/// NCBI TaxId: 286207
/// </summary>
public abstract class Polysyncraton : Didemnidae, IPolysyncraton
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polysyncraton";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 286207;

    /// <inheritdoc />
    public virtual string GenusName => "Polysyncraton";

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
