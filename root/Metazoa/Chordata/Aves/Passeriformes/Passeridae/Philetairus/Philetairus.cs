using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passeridae.Philetairus;

/// <summary>
/// Abstract class for Philetairus (genus).
/// NCBI TaxId: 247665
/// </summary>
public abstract class Philetairus : Passeridae, IPhiletairus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Philetairus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 247665;

    /// <inheritdoc />
    public virtual string GenusName => "Philetairus";

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
