using AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Pyrosomata.Pyrosomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Pyrosomata.Pyrosomatidae.Pyrosoma;

/// <summary>
/// Abstract class for Pyrosoma (genus).
/// NCBI TaxId: 76844
/// </summary>
public abstract class Pyrosoma : Pyrosomatidae, IPyrosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pyrosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 76844;

    /// <inheritdoc />
    public virtual string GenusName => "Pyrosoma";

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
