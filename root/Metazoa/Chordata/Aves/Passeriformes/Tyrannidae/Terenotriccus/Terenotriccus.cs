using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Terenotriccus;

/// <summary>
/// Abstract class for Terenotriccus (genus).
/// NCBI TaxId: 170869
/// </summary>
public abstract class Terenotriccus : Tyrannidae, ITerenotriccus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Terenotriccus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 170869;

    /// <inheritdoc />
    public virtual string GenusName => "Terenotriccus";

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
