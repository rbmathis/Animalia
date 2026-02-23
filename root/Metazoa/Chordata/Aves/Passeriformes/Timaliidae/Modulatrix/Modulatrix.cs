using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Timaliidae.Modulatrix;

/// <summary>
/// Abstract class for Modulatrix (genus).
/// NCBI TaxId: 254558
/// </summary>
public abstract class Modulatrix : Timaliidae, IModulatrix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Modulatrix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 254558;

    /// <inheritdoc />
    public virtual string GenusName => "Modulatrix";

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
