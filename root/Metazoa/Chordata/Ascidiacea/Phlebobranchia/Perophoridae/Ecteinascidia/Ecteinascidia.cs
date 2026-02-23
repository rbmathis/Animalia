using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Perophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Phlebobranchia.Perophoridae.Ecteinascidia;

/// <summary>
/// Abstract class for Ecteinascidia (genus).
/// NCBI TaxId: 284475
/// </summary>
public abstract class Ecteinascidia : Perophoridae, IEcteinascidia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ecteinascidia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 284475;

    /// <inheritdoc />
    public virtual string GenusName => "Ecteinascidia";

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
