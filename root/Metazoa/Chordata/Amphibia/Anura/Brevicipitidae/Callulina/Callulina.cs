using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brevicipitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Brevicipitidae.Callulina;

/// <summary>
/// Abstract class for Callulina (genus).
/// NCBI TaxId: 248776
/// </summary>
public abstract class Callulina : Brevicipitidae, ICallulina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Callulina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 248776;

    /// <inheritdoc />
    public virtual string GenusName => "Callulina";

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
