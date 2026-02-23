using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Ethmidium;

/// <summary>
/// Abstract class for Ethmidium (genus).
/// NCBI TaxId: 691794
/// </summary>
public abstract class Ethmidium : Clupeidae, IEthmidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ethmidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 691794;

    /// <inheritdoc />
    public virtual string GenusName => "Ethmidium";

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
