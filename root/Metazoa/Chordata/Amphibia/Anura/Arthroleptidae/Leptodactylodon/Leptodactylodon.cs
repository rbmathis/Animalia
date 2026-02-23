using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Arthroleptidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Arthroleptidae.Leptodactylodon;

/// <summary>
/// Abstract class for Leptodactylodon (genus).
/// NCBI TaxId: 147304
/// </summary>
public abstract class Leptodactylodon : Arthroleptidae, ILeptodactylodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptodactylodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 147304;

    /// <inheritdoc />
    public virtual string GenusName => "Leptodactylodon";

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
