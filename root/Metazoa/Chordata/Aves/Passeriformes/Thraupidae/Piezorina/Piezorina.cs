using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Piezorina;

/// <summary>
/// Abstract class for Piezorina (genus).
/// NCBI TaxId: 3150845
/// </summary>
public abstract class Piezorina : Thraupidae, IPiezorina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Piezorina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150845;

    /// <inheritdoc />
    public virtual string GenusName => "Piezorina";

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
