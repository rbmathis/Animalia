using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Callulops;

/// <summary>
/// Abstract class for Callulops (genus).
/// NCBI TaxId: 83966
/// </summary>
public abstract class Callulops : Microhylidae, ICallulops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Callulops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 83966;

    /// <inheritdoc />
    public virtual string GenusName => "Callulops";

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
