using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Caeciliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Caeciliidae.Caecilia;

/// <summary>
/// Abstract class for Caecilia (genus).
/// NCBI TaxId: 43453
/// </summary>
public abstract class Caecilia : Caeciliidae, ICaecilia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caecilia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43453;

    /// <inheritdoc />
    public virtual string GenusName => "Caecilia";

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
