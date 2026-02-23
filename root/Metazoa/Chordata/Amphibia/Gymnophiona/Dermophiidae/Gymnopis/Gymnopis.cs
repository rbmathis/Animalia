using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Dermophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Dermophiidae.Gymnopis;

/// <summary>
/// Abstract class for Gymnopis (genus).
/// NCBI TaxId: 264013
/// </summary>
public abstract class Gymnopis : Dermophiidae, IGymnopis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnopis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 264013;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnopis";

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
