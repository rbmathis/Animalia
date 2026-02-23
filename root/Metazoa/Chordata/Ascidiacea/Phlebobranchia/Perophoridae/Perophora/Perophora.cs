using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Perophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Perophoridae.Perophora;

/// <summary>
/// Abstract class for Perophora (genus).
/// NCBI TaxId: 111867
/// </summary>
public abstract class Perophora : Perophoridae, IPerophora
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Perophora";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 111867;

    /// <inheritdoc />
    public virtual string GenusName => "Perophora";

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
