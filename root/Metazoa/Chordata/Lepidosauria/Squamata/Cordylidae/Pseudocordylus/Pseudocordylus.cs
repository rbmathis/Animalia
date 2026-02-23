using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cordylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cordylidae.Pseudocordylus;

/// <summary>
/// Abstract class for Pseudocordylus (genus).
/// NCBI TaxId: 126625
/// </summary>
public abstract class Pseudocordylus : Cordylidae, IPseudocordylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudocordylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 126625;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudocordylus";

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
