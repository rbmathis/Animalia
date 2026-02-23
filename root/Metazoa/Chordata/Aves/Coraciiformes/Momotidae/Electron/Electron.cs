using AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Momotidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Coraciiformes.Momotidae.Electron;

/// <summary>
/// Abstract class for Electron (genus).
/// NCBI TaxId: 1118549
/// </summary>
public abstract class Electron : Momotidae, IElectron
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Electron";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1118549;

    /// <inheritdoc />
    public virtual string GenusName => "Electron";

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
