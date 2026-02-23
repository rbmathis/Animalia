using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Exerodonta;

/// <summary>
/// Abstract class for Exerodonta (genus).
/// NCBI TaxId: 374082
/// </summary>
public abstract class Exerodonta : Hylidae, IExerodonta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Exerodonta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 374082;

    /// <inheritdoc />
    public virtual string GenusName => "Exerodonta";

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
