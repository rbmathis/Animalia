using AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Pyrosomata.Pyrosomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Thaliacea.Pyrosomata.Pyrosomatidae.Pyrosomella;

/// <summary>
/// Abstract class for Pyrosomella (genus).
/// NCBI TaxId: 569440
/// </summary>
public abstract class Pyrosomella : Pyrosomatidae, IPyrosomella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pyrosomella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 569440;

    /// <inheritdoc />
    public virtual string GenusName => "Pyrosomella";

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
